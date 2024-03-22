using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PersonReport : Person
    {
        //สืบทอดมาจาก Person
        //เป็นคลาสแม่ของ PersonChecklist
        //เพื่อให้คลาสที่สืบทอดจากคลาสนี้สามารถใช้ร่ามได้
        protected string product;
        protected string MarketAccount;
        protected string MarketPlace;
       
        //ตั้งค่า product
        //Getter setter
        public void SetProduct(string product)
        {
            this.product = product;
        }
        
        //ตั้งค่า MarketAccount
        public void SetMarketAccount(string marketAccount)
        {
            MarketAccount = marketAccount;
        }
        
        //ตั้งค่า MarketPlace (แหล่งซื้อขาย เฟสบุ๊ค ไอจี ไลน์)
        public void SetMarketPlace(string marketPlace)
        {
            this.MarketPlace = marketPlace;
        }

        //คืนค่า Product
        public string GetProduct()
        {
            return this.product;
        }
        //คืนค่า MarketAcc
        public string GetMarketAcc()
        {
            return MarketAccount;
        }
        //คืนค่า MarketPlace
        public string GetMarketPlace()
        {
            return this.MarketPlace;
        }
    }
}
