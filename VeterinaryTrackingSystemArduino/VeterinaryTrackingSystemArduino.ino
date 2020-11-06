/*
 THIS ARDUINO CODE PREPARED BY MUSTAFA MERT KARPUZ
 IT IS Adjusted according to the veterinary tracking system
 */

#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9
MFRC522 mfrc522(SS_PIN, RST_PIN);   // Create MFRC522 instance.

void setup() {
    Serial.begin(9600); // Initialize serial communications with the PC
    SPI.begin();            // Init SPI bus
    mfrc522.PCD_Init(); // Init MFRC522 card
    Serial.println("Scan PICC to see UID and type...");
}

void loop() {
    // Look for new cards
    if ( ! mfrc522.PICC_IsNewCardPresent()) {
        return;
    }

    // Select one of the cards
    if ( ! mfrc522.PICC_ReadCardSerial()) {
        return;
    }

    
    mfrc522.PICC_DumpToSerial(&(mfrc522.uid));

    Serial.print("UID size : ");
    Serial.println(mfrc522.uid.size);

 Serial.print("Printing HEX UID : ");
  for (byte i = 0; i < mfrc522.uid.size; i++) {
    Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
    Serial.print(mfrc522.uid.uidByte[i], HEX);
  } 
  Serial.println("");

  unsigned long UID_unsigned;
  UID_unsigned =  mfrc522.uid.uidByte[0] << 24;
  UID_unsigned += mfrc522.uid.uidByte[1] << 16;
  UID_unsigned += mfrc522.uid.uidByte[2] <<  8;
  UID_unsigned += mfrc522.uid.uidByte[3];

  Serial.println();
  Serial.println("UID Unsigned int"); 
  Serial.println(UID_unsigned);

  String UID_string =  (String)UID_unsigned;
  long UID_LONG=(long)UID_unsigned;

  Serial.println("UID Long :");
  Serial.println(UID_LONG);

  Serial.println("UID String :");
  Serial.println(UID_string);
}
