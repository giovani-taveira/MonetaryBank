using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows;

namespace DataBase
{
    public class AcessoDB
    {
        public static bool InsereCliente(Cliente pCliente)
        {
            try
            {
                DataClasses1DataContext oDB = new DataClasses1DataContext();
                oDB.Cliente.InsertOnSubmit(pCliente);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Ocorreu um erro ao realizar o cadastro");
                return false;
            }
        }
        public static bool DeleteCliente(string cpf)
        {
            try
            {
                DataClasses1DataContext oDB = new DataClasses1DataContext();
                Cliente c = (from selecao in oDB.Cliente where selecao.CPF == cpf select selecao).SingleOrDefault();
                oDB.Cliente.DeleteOnSubmit(c);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Ocorreu um erro ao deletar a conta");
                return false;
            }
        }

        public static bool AtualizaSenha(LoginTable NovaSenha ,Cliente cpf)
        {
            try
            {
                LoginDataContext oDB = new LoginDataContext();
                LoginTable c = (from selecao in oDB.LoginTable where selecao.CPF == cpf.CPF select selecao).SingleOrDefault();

                c.Senha = NovaSenha.Senha;

                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Ocorreu um erro ao fazer a nova senha");
                return false;
            }
        }
    }
}
