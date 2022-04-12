using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPattern.Strategy
{
    public interface IEncodingStrategy
    {
        void EncodeValue(string value);
    }
    public class RSAEncodingStrategy : IEncodingStrategy
    {
        public void EncodeValue(string value)
        {            
            Console.WriteLine("Value {0} is Encoded using RSA Algorithm", value);
        }
    }
    public class DESncodingStrategy : IEncodingStrategy
    {
        public void EncodeValue(string value)
        {            
            Console.WriteLine("Value {0} is Encoded using DES Algorithm", value);
        }
    }
    public class BlowFishEncodingStrategy : IEncodingStrategy
    {
        public void EncodeValue(string value)
        {
            
            Console.WriteLine("Value {0} is Encoded using BlowFish Algorithm", value);
        }
    }
    public class Encoding
    {
        private IEncodingStrategy _encodeStrategy;

        public Encoding(IEncodingStrategy encodeStrategy)
        {
            _encodeStrategy = encodeStrategy;
        }

        public void Encode(string value)
        {
            _encodeStrategy.EncodeValue(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEncodingStrategy encodingStrategy = new RSAEncodingStrategy();
            Encoding encoding = new Encoding(encodingStrategy);
            encoding.Encode("10000011110");

            encodingStrategy = new DESncodingStrategy();
            encoding = new Encoding(encodingStrategy);
            encoding.Encode("10000011110");

            encodingStrategy = new BlowFishEncodingStrategy();
            encoding = new Encoding(encodingStrategy);
            encoding.Encode("10000011110");

            Console.ReadLine();
        }
    }
}
