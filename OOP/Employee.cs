using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Employee
    {
        #region Nhom cac thuoc tinh cua Employee
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _id_card;
        private string _name_card;
        #endregion
        #region Nhom cac property cue Employee
        public int Id { get { return _id; } set { _id = value; } }  
        public string Name { get { return _name; } set { _name = value; } }     
        public string Email { get { return _email; } set { _email = value; } }  
        public string Phone { get { return _phone; } set { _phone = value; } }  
        public string IdCard { get { return _id_card; } set { _id_card = value; } }
        #endregion
    
        public void printInfor()
        {
            String msg =$"{Id}\t{Name}\t{Email}\t{Phone}\t{IdCard}";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            String msg = $"{Id}\t{Name}\t{Email}\t{Phone}\t{IdCard}";
            return msg;
        }

        public Employee(int _id, string _name, string _id_card, string _email, string _phone)
        {
            #region Nhom cac constructor cua employee
            this._id = _id;
            this._name = _name;
            this._id_card = _id_card;
            Email = _email;
            Phone = _phone;
            #endregion
        }
    }
}
