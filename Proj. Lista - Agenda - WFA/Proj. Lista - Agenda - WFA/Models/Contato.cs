using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proj._Lista___Agenda___WFA.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Data DtNasc { get; set; }
        public List<Telefone> Telefones { get; private set; }

        public Contato()
        {
            Nome = "";
            Email = "";
            DtNasc = new Data();
            Telefones = new List<Telefone>();
        }

        public Contato(string email, string nome, Data dtNasc)
        {
            Email = email;
            Nome = nome;
            DtNasc = dtNasc;
            Telefones = new List<Telefone>();
        }

        public void AdicionarTelefone(Telefone t)
        {
            Telefones.Add(t);
        }

        public string GetTelefonePrincipal()
        {
            foreach (Telefone t in Telefones)
            {
                if (t.Principal)
                    return t.Numero;
            }
            return "";
        }

        public int GetIdade()
        {
            int idade = DateTime.Now.Year - DtNasc.Ano;
            if (DateTime.Now.Month < DtNasc.Mes || (DateTime.Now.Month == DtNasc.Mes && DateTime.Now.Day < DtNasc.Dia))
                idade--;
            return idade;
        }

        public override string ToString()
        {
            string telefonePrincipal = GetTelefonePrincipal();
            return $"Nome: {Nome}\nEmail: {Email}\nData Nascimento: {DtNasc}\nTelefone Principal: {telefonePrincipal}\nIdade: {GetIdade()}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Contato c)
                return this.Email == c.Email;
            return false;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}