using System;

namespace SOLID.OCP
{
    /*
     * In aceasta situatie nu am putut folosi strategy pattern deoarece daca dorim sa creem mai multe instante de acelasi tip vom primi
     * doar o referinta la o instanta deja existenta.
     * 
     * Am decis sa folosim template-uri, astfel renuntand la BankTerminalModel, utilizatorul va creea noi instante oferind numele clasei ca template
     * in loc de model ca parametru al metodei.
     * 
    *var temp = new BankTerminalFactory();
    *temp.CreateBankTerminal<BrpTerminal>();
    */

    public class BankTerminalFactory
    {
        public static T CreateBankTerminal<T>() where T : IBankTerminal, new()
        {
            return new T();
        }
    }

}