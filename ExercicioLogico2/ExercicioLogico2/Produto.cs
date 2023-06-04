using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogico2
{
    internal class Produto
    {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public string GetNome() { return _nome;}
        public void SetNome(string nome) {_nome = nome;}

        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this()
        {

            _nome = nome;
            _preco = preco;
            _quantidade = 10;
        }

        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AddProdutoEstoque(int quantidadeUser)
        {

            _quantidade += quantidadeUser;

        }

        public void RemoveProdutoEstoque(int quantidadeUser)
        {

            _quantidade -= quantidadeUser;

        }

        public override string ToString()
        {
            return "Nome: " + _nome + " Preço: R$" + _preco.ToString("F2", CultureInfo.InvariantCulture) + " Unidades: " + _quantidade;
        }
    }
}
