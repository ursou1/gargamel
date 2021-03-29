using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class Phones
    {
        public List<IPhone> ListPhones { get; set; } = new List<IPhone>();
        public List<Phones> ListPhoness = new List<Phones>();
        public IPhone DefaultPhone { get; set; }

        public void AddPhone(string number)
        {

            MobilePhone mp = new MobilePhone(number);
            mp.Number = number;
            if (ListPhones != null && ListPhones.Count == 0)
            {
                ListPhones = new List<IPhone>();
                ListPhones.Add(mp);
                ListPhones.Add(DefaultPhone);
            }
            else
            {
                ListPhones.Add(mp);
            }
        }
        public void ChangeTypePhone(IPhone phone)
        {
            int index = ListPhones.IndexOf(phone);
            if (index == ListPhones.IndexOf(phone))
            {
                if (phone is MobilePhone)
                {
                    TownPhone townPhone = new TownPhone { Number = phone.Number };
                }
                if (phone is TownPhone)
                {
                    MobilePhone mobilePhone = new MobilePhone { Number = phone.Number };
                }
                if (phone == DefaultPhone)
                {
                    DefaultPhone = phone;
                }
                ListPhones.RemoveAt(index);
                ListPhones.Add(phone);
            }
            else
            {
                return;
            }
        }
        public void RemovePhone(IPhone phone)
        {

            ListPhones.Remove(phone);

        }
    }
}
