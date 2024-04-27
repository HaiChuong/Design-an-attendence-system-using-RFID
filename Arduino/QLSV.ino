
#include <MFRC522.h>
#include <LiquidCrystal_I2C.h>
#include <EEPROM.h>
#include <SoftwareSerial.h>
#include <String.h>

#define SS_PIN 10
#define RST_PIN A6
#define PASS_ADDR 0
#define ID_ADDR 100
MFRC522 mfrc522(SS_PIN,RST_PIN); 
LiquidCrystal_I2C lcd(0x27, 16, 2);
 #define Led 3
 #define Servo_0 A2
 #define buzzerPin A3
#define TX_PIN 5                   
#define RX_PIN 4           
SoftwareSerial Zigbee(RX_PIN, TX_PIN);
char *tagUID1;

int flagDiemDanh = 0, flagQuetThe = 0;
boolean RFID = false; 
uint8_t i = 0;  
uint8_t flag_read_rfid = 0 ;
String val;
int mode_process =0;
String str1 = "0",str2,str3, old_str1; 


int ProcessControl = 1;


volatile int state = 0;   
unsigned int count = 0;    
                          
String inputString = "";      
bool stringComplete = false;  
bool sendSerial = false;      
  String strData = "";      
  boolean receive_done = false;
  String CardId;
  String fullData,return_result;

void RFID_process();



void setup() {
	
	pinMode(buzzerPin, OUTPUT);
	pinMode(Led, OUTPUT);
	digitalWrite(buzzerPin,1);
	digitalWrite(Led,0);
	lcd.init();
	lcd.backlight();
	SPI.begin();      
	mfrc522.PCD_Init();   
	lcd.clear(); 
	digitalWrite(Led, LOW);
	Serial.begin(9600);
	Zigbee.begin(9600);
	lcd.clear();
	inputString.reserve(200);
}


void loop()
{

	state = receiveData2(str1, str2,str3); 
	ProcessControl = str1.toInt();
	if (state == 2)  
	{
		ProcessControl = 100;		
	}
	if (state == 1)
	{
		old_str1 = str1;
	}
	if (state == 3)
	{
		str1 = old_str1;
	}	
 switch (ProcessControl)
 {
  case 0:
    lcd.setCursor(0, 0);
    lcd.print("Cho ket noi he  "); 
    lcd.setCursor(0, 1);
    lcd.print("thong        "); 
    flagDiemDanh = 1;
    flagQuetThe = 1;
    break;
  case 1: 
    lcd.setCursor(0, 0);
    lcd.print("Q.the de d.danh           ");
    if(flagDiemDanh == 1)
    {    
      lcd.clear();
      flagDiemDanh = 0;
      flagQuetThe = 1;
    }
    RFID_process();
    break;
  case 2: 
    lcd.setCursor(0, 0);
    lcd.print("Quet the RFID        ");
    if(flagQuetThe == 1)
    {    
		lcd.clear();
		flagDiemDanh = 1;
		flagQuetThe = 0;
    }    
    RFID_process2();
    break;
  case 11: 
    lcd.setCursor(0, 1);
    lcd.print(str3);
    lcd.print("         ");
    str1 = "01";
  break;
	case 100:
	lcd.setCursor(0, 0);
	lcd.print("Du lieu nhan sai    ");
	lcd.setCursor(0, 1);
	lcd.print("dinh dang      ");
	flagQuetThe = 1;
	flagDiemDanh = 1;
	delay(1000);
  break;	
     
 }
}
void test()
{
 serialEvent();
if (stringComplete) 
{
	lcd.clear();
	lcd.setCursor(0, 0);
	lcd.print(inputString);
	lcd.setCursor(0, 1);
	lcd.print(inputString.length());
	Serial.println(inputString);
	stringComplete = false;
	inputString = "";  
} 
}
void serialEvent() {
  while (Serial.available()) {
    
    char inChar = (char)Serial.read();
        if (inChar == 'f') {  
      stringComplete = true;
       delay(100);
    }
    else
    {
      inputString += inChar;     
      }
    
  }
}


void RFID_process() 
{
    if ( ! mfrc522.PICC_IsNewCardPresent()) {   
      
  digitalWrite(Led,1);
      return;
    }
    
    if ( ! mfrc522.PICC_ReadCardSerial()) {
      return;
    }
    
    CardId ="";
    for (byte j = 0; j < mfrc522.uid.size; j++)
    {
      CardId.concat(String(mfrc522.uid.uidByte[j] < 0x10 ? " 0" : ""));
      CardId.concat(String(mfrc522.uid.uidByte[j],HEX));
    }
	String sendToPC;
	sendToPC = "11-01-00-"+CardId+"-" ;

	sendToPC = sendToPC + String(sendToPC.length()+3)+"-f";
	Zigbee.println(sendToPC); 
	digitalWrite(buzzerPin,0);
	mfrc522.PICC_HaltA();
}
void RFID_process2() // Quet  the lay ma 
{
    if ( ! mfrc522.PICC_IsNewCardPresent()) { 
       
      return;
    }
    
    if ( ! mfrc522.PICC_ReadCardSerial()) {
      return;
    }
    digitalWrite(Led,1);  
    
    CardId ="";
    for (byte j = 0; j < mfrc522.uid.size; j++)
    {
      CardId.concat(String(mfrc522.uid.uidByte[j] < 0x10 ? " 0" : ""));
      CardId.concat(String(mfrc522.uid.uidByte[j],HEX));
    }
	digitalWrite(buzzerPin,0);
	lcd.setCursor(0, 1);
	lcd.print(CardId);lcd.print(" ");
	String sendToPC;
	sendToPC = "11-02-00-"+CardId+"-" ;
	sendToPC = sendToPC + String(sendToPC.length()+3)+"-f";
	Zigbee.println(sendToPC);
 digitalWrite(buzzerPin,1); 
	mfrc522.PICC_HaltA();
}

int receiveData2(String& part1, String& part2, String& part3)

{
  
  while (Zigbee.available()) {
    char inChar = (char)Zigbee.read();
    if (inChar == 'f') 
    {         
      receive_done = true;
     
    }
    else
    {
      strData += inChar;
    }
  }
  if (receive_done)
  {
     
      String ini_string;
      String Check_sum;
    
    
    int idx1 = strData.indexOf('-');
  if (idx1 != -1) {
    ini_string = strData.substring(0, idx1);
    int idx2 = strData.indexOf('-', idx1 + 1);
    if (idx2 != -1) {
      part1 = strData.substring(idx1 + 1, idx2);
      int idx3 = strData.indexOf('-', idx2 + 1);
      if (idx3 != -1) {
        part2 = strData.substring(idx2 + 1, idx3);
        int idx4 = strData.indexOf('-', idx3 + 1);
        if (idx4 != -1) {
          part3 = strData.substring(idx3 + 1, idx4);
          Check_sum = strData.substring(idx4 + 1,idx4 + 3);
        }
      }
    }
  }
    //--------------------------------------------
      receive_done = false;
      
      if (ini_string =="00" && Check_sum == String(strData.length()))
      {
		strData="";
		digitalWrite(Led,0);
    digitalWrite(buzzerPin,1);
		return 1;  
      }
      else   
      {
        strData="";
        return 2;
        
      } 
  }
  else return 3;
      
}
bool send_data(String value , int time_out) 
{
	bool kq= false;
	int start_time = millis;
	digitalWrite(Led, HIGH);
	Zigbee.println(value);
	
	while (millis - start_time < time_out)
	{
		while (Zigbee.available()) 
		{
			char inChar = (char)Zigbee.read();
			if (inChar == 'f') 
			{        
				receive_done = true;
			}
			else
			{
				strData += inChar;
			}
		}
		if (receive_done)
		{
			receive_done = false;   
			if(strData == "0091")
			{
			kq = true; 
			digitalWrite(Led, LOW);
			strData = "";                 
			}
			else 
			{
			break;
			}
		}					
	}

	return kq;
}
