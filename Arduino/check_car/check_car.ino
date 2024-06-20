#include <Arduino.h>
#include <Wire.h>
#include <SPI.h>
#include <MFRC522.h>
#include <Servo.h>

// Chân kết nối cho Module RFID
#define RST_PIN 9
#define SS_PIN 10

#define button 7      // button
#define sensor_in 4 // Cảm biến vào
#define sensor_out 5 // Cảm biến ra
#define servo_in 2
#define servo_out 3

#define OPEN 1
#define CLOSE 0

int temp = 0;
char buffer[2];
bool status_car_in = false;
bool status_car_out = false;
int slot = 3;
int buttonState = 0;   

Servo inServo;
Servo outServo;

MFRC522 mfrc522(SS_PIN, RST_PIN); // Tạo đối tượng MFRC522 cho module RFID
// Danh sách UID hợp lệ
String card2 = "74 66 85 71";
String card3 = "44 34 7F 71";
String card4 = "A3 1E E9 1A";

String receivedUID = ""; // Chuỗi lưu UID nhận được qua I2C
unsigned char card = 0;

void setup() {
  Serial.begin(9600);  // Khởi động giao tiếp serial
  SPI.begin();         // Bắt đầu giao tiếp SPI
  pinMode(button, INPUT_PULLUP);
  pinMode(sensor_in, INPUT);
  pinMode(sensor_out, INPUT);
  digitalWrite(button, LOW);
  inServo.attach(servo_in);
  outServo.attach(servo_out);
  inServo.write(0);  // Đặt servo vào chế độ nằm ngang
  outServo.write(180); // Đặt servo vào chế độ nằm ngang

  Wire.begin(8);      // Khởi tạo thư viện I2C với địa chỉ 8
  Wire.onReceive(receiveEvent);  // Đăng ký hàm nhận sự kiện I2C

  mfrc522.PCD_Init();  // Khởi động module RFID

  Serial.println("RFID ready...");
}

void loop() {
  // Kiểm tra và đọc thẻ từ module RFID
  if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()) {
    printUID(mfrc522);
  }
  mfrc522.PICC_HaltA();
  mfrc522.PCD_StopCrypto1();

  // Xử lý trường hợp vào
  handleEntryCase();

  // Kiểm tra trạng thái cảm biến vào
  checkInSensor();

  // Xử lý trường hợp xe vào
  handleCarEntry();

  // Xử lý trường hợp ra
  handleExitCase();

  // Kiểm tra trạng thái cảm biến ra
  checkOutSensor();

  // Xử lý trường hợp xe ra
  handleCarExit();

}

void printUID(MFRC522 &mfrc522) {
  String uidString = "";
  for (byte i = 0; i < mfrc522.uid.size; i++) {
    if (i > 0) {
      uidString += " ";  // Thêm khoảng trắng giữa các byte
    }
    uidString += String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "") + String(mfrc522.uid.uidByte[i], HEX);
  }
  uidString.toUpperCase();  // Chuyển chuỗi thành chữ in hoa

  // So sánh với danh sách UID hợp lệ
  if (uidString == card2) {
    card = 2;
  } else if (uidString == card3) {
    card = 3;
  } else if (uidString == card4) {
    card = 4;
  } else {
    Serial.println("UID không hợp lệ: " + uidString);
  }

  Serial.println(card);
}

void receiveEvent(int howMany) {
  receivedUID = "";  // Đặt chuỗi rỗng ban đầu
  while (Wire.available()) {
    char c = Wire.read();
    receivedUID += c;
  }
  receivedUID.trim();  // Xóa khoảng trắng thừa

  // So sánh với danh sách UID hợp lệ
  if (receivedUID == card2) {
    card = 6;
  } else if (receivedUID == card3) {
    card = 7;
  } else if (receivedUID == card4) {
    card = 8;
  } else {
    Serial.println("Received UID không hợp lệ: " + receivedUID);
  }

  Serial.println(card);
}

void handleEntryCase() {
  if (card == 2 || card == 3 || card == 4) {
    unsigned long time_check = millis();
    bool signalReceived = false;
    while (millis() - time_check < 200) {
      unsigned char c = getSerial();
      if (c == 1 && buffer[0] == 'A') {
        BareIn(OPEN);
        Serial.println("Received in A");
        signalReceived = true;
        break;
      } else if (c == 1 && buffer[0] == 'B') {
        Serial.println("Received in B");
        signalReceived = true;
        break;
      }
    }
  }
}

void checkInSensor() {
  // Kiểm tra xem cảm biến có bị kích hoạt hay không
  if (digitalRead(sensor_in) == LOW) {
    status_car_in = true;
  }
}

void handleCarEntry() {
  // Nếu cảm biến không bị kích hoạt và trạng thái trước đó là có xe (status_car_in là true)
  if (digitalRead(sensor_in) == HIGH && status_car_in) {
    status_car_in = false; // Đặt lại trạng thái
    BareIn(CLOSE);         // Đóng barrier
  }
}

void handleExitCase() {
  if (card == 6 || card == 7 || card == 8) {
    unsigned long time_check = millis();
    //bool signalReceived = false;
    while (millis() - time_check < 200) {
      unsigned char c = getSerial();
      if (c == 1 && buffer[0] == 'A') {
        BareOut(OPEN);
        Serial.println("Received out A");
        break;
      } else if (c == 1 && buffer[0] == 'B') {
        Serial.println("Received out B");

        // Vòng lặp lồng vào để kiểm tra trạng thái nút trong 200ms bổ sung
        // unsigned long button_check_start = millis();  // Thời gian bắt đầu cho vòng lặp kiểm tra nút
        // while (millis() - button_check_start < 20000) {  // Tiếp tục kiểm tra trạng thái của nút trong 20000ms (20 giây)
        //   Serial .println(buttonState);
        //   buttonState = digitalRead(button); // Đọc trạng thái của nút bấm trong vòng lặp
        //   if (buttonState == HIGH) { // Nếu nút được nhấn (LOW do pull-up nội bộ)
        //     Serial.println("Button");
        //     BareOut(OPEN);  // Mở barrier
        //     break;  // Thoát khỏi vòng lặp kiểm tra nút khi nút được nhấn
        //   }
        // } 
        break;
      }
    }
  }
}

void checkOutSensor() {
  if (digitalRead(sensor_out) == LOW) {
    status_car_out = true;
  }
}

void handleCarExit() {
  if (digitalRead(sensor_out) == HIGH && status_car_out) {
    status_car_out = false; // Đặt lại trạng thái
    BareOut(CLOSE);         // Đóng barrier
  }
}

void BareIn(int status) {
  if (status == OPEN) {
    Serial.println("Bare IN open ");
    inServo.write(90);
  } else if (status == CLOSE) {
    inServo.write(0);
    Serial.println("Bare In close ");
  }
}

void BareOut(int status) {
  if (status == OPEN) {
    Serial.println("Bare Out open ");
    outServo.write(90);
    Serial.println("out fun bare out ");
  } else if (status == CLOSE) {
    Serial.println("Bare Out close ");
    outServo.write(180);
  }
}

unsigned char getSerial() {
  if (Serial.available()) {
    char c = Serial.read();
    if (c == 'A' || c == 'B') {
      buffer[0] = c;
      return 1;
    }
  }
  return 0;
}





