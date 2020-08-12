using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
       // public int Id { get; set; }

        public List<String> _mensagensValidacao { get; set; }
    
        protected List<String> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();
        /*
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
           
        }

        */
    }
}
