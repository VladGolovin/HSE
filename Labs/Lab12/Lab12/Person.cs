using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Person
    {
        public class InvalidPassportNumberException: Exception
        {
            public override string Message
            {
                get
                {
                    return "Номер паспорта не должен выходить за рамки диапазона от 1 до 999 999.";
                }
            }
        }

        private int passportNumber;

        public int PassportNumber
        {
            get
            {
                return passportNumber;
            }
            set
            {
                if (value > 999999 || value < 1)
                {
                    throw new InvalidPassportNumberException();
                }

                passportNumber = value;
            }
        }

        public override string ToString()
        {
            return passportNumber.ToString();
        }
    }
}
