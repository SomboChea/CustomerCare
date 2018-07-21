using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCare
{
    interface IModel
    {
        void print();
    }

    class Model : IModel, IConvertible
    {
        private static object _instance = null;

        public static T Get<T>(object model)
        {
            _instance = model;
            return (T)Convert.ChangeType(model, typeof(T));
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public virtual void print()
        {
            Console.WriteLine("System has printed in Model");
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return _instance;
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }

    class SubModel : Model
    {
        public override void print()
        {
            Console.WriteLine("System has printed in SubModel");
        }
    }

    class SubSubModel : SubModel
    {
        public override void print()
        {
            Console.WriteLine("System has printed in SubSubModel");
        }

        public void GetSubSubModel()
        {
            Console.WriteLine("Get Sub Sub Model");
        }
    }

    class Student : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return String.Format("ID: {0} - Name: {1}", Id, Name);
        }
    }

    class Tutor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void ToPrint()
        {
            Console.WriteLine("ID: {0} and Name: {1}", Id, Name);
        }
    }

    class Payment
    {
        public bool IsPaid { set => _isPaid = value; }
        private bool _isPaid = false;
        public void GetPaid()
        {
            Console.WriteLine(_isPaid ? "Has Paid!" : "Not Paid yet!");
        }
        public void Processing()
        {
            Console.WriteLine("Payment is processing...");
        }
    }

    class MyMeanitry : Meanitry
    {
        public void Print()
        {
            Console.WriteLine("System has printed in MyMeanitry");
        } 
    }
}
