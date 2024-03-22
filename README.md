### ความเป็นมาของโปรแกรม
ได้รับแรงบันดาลใจมาจากเว็บไซต์ https://www.blacklistseller.com/ 

### วัตถุประสงค์ของโปรแกรม
เป็นโปรแกรมสำหรับบันทึกข้อมูลของผู้ขายที่ถูกแบล็คลิสต์ให้ผู้ซื้อได้มาตรวจสอบ ก่อนจะทำการซื้อขายใดๆกับผู้ที่คาดว่าน่าจะถูกแบล็คลิสต์

### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Person <|-- PersonReport
    PersonReport <|-- PersonChecklist
    Form1 -- Form2
    Form1 -- Form3
    Form2 -- DatabaseBLacklist
    Form2 -- PersonReport
    Form3 -- PersonChecklist
    Form3 -- DatabaseBLacklist
    DatabaseBLacklist -- CSV

    
    class Form1{
        -ReportBlack_Click()
        -CheckBlack_Click()
    }
    class Form2{
        -DatabaseBLacklist database 
        -PersonReport person
        -ReportBTN_Click()
    }
    class Form3{
        -PersonChecklist person
        -DatabaseBLacklist database 
        -CheckListBTN_Click()
    }
    class Person{
        #string name
        #string IDcardNumber
        #string AccountName
        +Setname()
        +SetID()
        +SetAccount()
        +GetName()
        +GetID()
        +GetAccountName()
    }
    class PersonReport{
        -string product
        -string MarketAccount
        -string MarketPlace
        +SetProduct()
        +SetMarketAccount()
        +SetMarketPlace()
        +GetProduct()
        +GetMarketAcc()
        +GetMarketPlace()
    }
    class PersonChecklist{
        -DatabaseBLacklist database
        +CheckList()
    }
    class DatabaseBLacklist{
        -CSV csv
        +Report()
        +CheckList()
    }
    class CSV{
        -string path
        -string[] content 
        +Savetofile(PersonReport person)
        +Readfile()
        +GetData()
    }

```

ผู้พัฒนาโปรแกรม
นาย จตุภัทร อนุเดชากุล รหัสนักศึกษา 663450035-5