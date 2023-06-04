﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogico2
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AddProdutoEstoque(int quantidadeUser)
        {

            Quantidade += quantidadeUser;

        }

        public void RemoveProdutoEstoque(int quantidadeUser)
        {

            Quantidade -= quantidadeUser;

        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + " Unidades: " + Quantidade;
        }
    }
}