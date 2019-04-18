using System;

namespace Account
{
    public class Account
    {
        public string Customer { get; set; }
        public int Cash { get; set; }
        public bool IsActive { get; set; }

        public Account(string customer, int cash)
        {
            Cash = cash;
            Customer = customer;
            IsActive = true;
        }

        public void IncreaseCash(int value)
        {
            if (value < 0)
                throw new Exception("مبلغ زیر صفر");

            Cash += value;
        }

        public void DecreaseCash(int value)
        {
            if (!IsActive)
                throw new Exception("حساب مسدود است");

            if (value < 0)
                throw new Exception("مبلغ زیر صفر");

            if (Cash < value)
                throw new ArgumentOutOfRangeException("ورودی بیشتر از موجودی است");

            Cash -= value;
        }

        public void ChangeActivation()
        {
            IsActive = !IsActive;
        }
    }
}