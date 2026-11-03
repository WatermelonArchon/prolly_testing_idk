using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BankAccountTest
    {

        [TestMethod]
        public void Debit_30and45_throwreturned()
        {
            //arrange- тестовое окружение
            int m_balance = 30;
            int amount = 45;
            int expected = 75;

            //act- действия теста
            BankAccountNS.BankAccount bank1 = new BankAccountNS.BankAccount("Smolyakov", m_balance);
            bank1.Debit(amount);
            double actual = bank1.Balance;
            //assert- ожидаемый результат
            Assert.AreEqual(expected, actual);
        }
    }
}

 
    
