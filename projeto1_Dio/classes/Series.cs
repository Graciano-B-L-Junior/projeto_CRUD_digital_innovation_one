using System;

namespace projeto1_Dio{
    public class Series:EntidadeBase{
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Series(int id,Genero genero,string titulo,string descricao,int ano){
            this.Id =id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno ="";
            retorno+= "Gênero: "+this.Genero+Environment.NewLine;
            retorno+= "Titulo: "+this.Titulo+Environment.NewLine;
            retorno+= "Descrição: "+this.Descricao+Environment.NewLine;
            retorno+= "Ano: "+this.Ano+Environment.NewLine;
            return retorno;
        }
        public string returnTitulo(){
            return this.Titulo;
        }
        public int returnAno(){
            return this.Ano;
        }
    }
}