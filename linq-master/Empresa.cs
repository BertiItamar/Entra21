﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Empresa
    {
        List<Caminhao> caminhoes = new List<Caminhao>();    
        public List<Viagem> viagens = new List<Viagem>();
        List<Motorista> motoristas = new List<Motorista>();

        public void CadastroCaminhao()
        {
            Caminhao caminhao = new Caminhao();
            Console.WriteLine("Digite o modelo do caminhão: ");
            caminhao.Modelo = Console.ReadLine();
            Console.WriteLine("Digite a placa do caminhão: ");
            caminhao.Placa = Console.ReadLine();        
            this.caminhoes.Add(caminhao);
        }
        public void CadastroMotorista()
        {
            Motorista motorista = new Motorista();
            Console.WriteLine("Digite o nome do motorista: ");
            motorista.Nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço do motorista: ");
            motorista.Endereco = Console.ReadLine();
            motoristas.Add(motorista);
        }    
        public void CadastroViagens()
        {
            Viagem viagem = new Viagem();
            viagem.Caminhao = SelectCaminhao();
            viagem.Motorista = SelectMotorista();
            viagens.Add(viagem);               
        }
        public void AtualizarCaminhao()
        {
            MostrarCaminhoesDisponiveis();
            int i = BuscarIndiceCaminhao();
            Console.WriteLine("Atualize o modelo do caminhão: ");
            caminhoes[i].Modelo = Console.ReadLine();
            Console.WriteLine("Atualize a placa do caminhão: ");
            caminhoes[i].Placa = Console.ReadLine();
        }
        public void AtualizarMotorista()
        {
            MostrarMotoristasDisponiveis();
            int i = BuscarIndiceMotorista();
            Console.WriteLine("Digite o nome do motorista: ");
            motoristas[i].Nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço do motorista: ");
            motoristas[i].Endereco = Console.ReadLine();
        }
        public void AtualizarViagem()
        {
            MostrarCaminhoesDisponiveis();
            int i = BuscarIndiceViagem();
            Console.WriteLine("Alterar a viagem: ");
            viagens[i].Caminhao = SelectCaminhao();
            viagens[i].Motorista = SelectMotorista();
        }
        public void RemoverCaminhao()
        {
            caminhoes.RemoveAt(BuscarIndiceCaminhao());           
        }
        public void RemoveMotorista()
        {
            motoristas.RemoveAt(BuscarIndiceMotorista());
        }
        public void RemoveViagem()
        {
            viagens.RemoveAt(BuscarIndiceViagem());   
        }
        private void MostrarCaminhoesDisponiveis()
        {
            foreach(Caminhao caminhao in this.caminhoes)
            {
                Console.WriteLine(caminhao.ToString());
            }
        }
        public  List<Viagem> EncontrarViagensPorMotorista(string nomeMotorista)
        {            
            return viagens.Where(viagem => viagem.Motorista.Nome == nomeMotorista).ToList();
        }   
        public List<Viagem> EncontrarViagensPorCaminhao(string modeloCaminhao)
        {
            return viagens.Where(viagem => viagem.Caminhao.Modelo == modeloCaminhao).ToList();
        }
        public List<Caminhao> EncontrarCaminhoesPorMotoristaEmViagem(string nomeMotorista)
        {
            var viagensPorMotorista = viagens.Where(viagem => viagem.Motorista.Nome == nomeMotorista).ToList();
            var caminhoes = new List<Caminhao>();
            viagensPorMotorista.ForEach(viagem => caminhoes.Add(viagem.Caminhao));
            return caminhoes;
        }
        public List<Viagem> EncontrarViagensPorCaminhaEMotoristaEspecifico(string placa, string nome)
        {              
            List<Viagem> viagens1 = new List<Viagem>();
            viagens1 = viagens.Where(viagem => viagem.Caminhao.Placa == placa).ToList();
            viagens1 = viagens.Where(viagem => viagem.Motorista.Nome == nome).ToList();
            return viagens1;
        }
        public List<Viagem> ViagensQueMotoristaNaoEstava(string nomeMotorista)
        {
            List<Viagem>viagemQueMotoristaNaoEstava = new List<Viagem>();
            viagemQueMotoristaNaoEstava = viagens.Where(viagem => viagem.Motorista.Nome == nomeMotorista).ToList();
            if(viagemQueMotoristaNaoEstava.Count == 0)
            {
                return viagemQueMotoristaNaoEstava;
            }
            return null;      
        }
        public List<Viagem> ViagensQueMotoristaECaminhaoNaoEstavam(string nomeMotorista, string placa)
        {
            List<Viagem> viagemQueNaoEstavam = new List<Viagem>();
            viagemQueNaoEstavam = viagens.Where(viagem => viagem.Motorista.Nome == nomeMotorista).ToList();
            viagemQueNaoEstavam = viagens.Where(Viagem => Viagem.Caminhao.Placa == placa).ToList();
            if(viagemQueNaoEstavam.Count == 0)
            {
                return viagemQueNaoEstavam;
            }
            return null;
        }


        private Caminhao SelectCaminhao()
        {
            int id = 0;
            Caminhao veiculo = null;
            var caminhaoQuery =
              from Caminhao caminhao in this.caminhoes
              where caminhao.Id == id
              select caminhao;
            MostrarCaminhoesDisponiveis();
            while (veiculo == null)
            {
                Console.WriteLine("Digite o ID do veículo: ");
                id = Convert.ToInt32(Console.ReadLine());
                foreach (var caminhao in caminhaoQuery)
                {
                    veiculo = caminhao;
                }            
            }
            return veiculo;
        }
      
        private void MostrarMotoristasDisponiveis()
        {

            foreach(Motorista motorista in this.motoristas)
            {
                Console.WriteLine(motorista.ToString());
            }
        }
        private Motorista SelectMotorista()
        {
            int id = 0;
            Motorista pessoa = null;
            var motoristaQuery =
                from Motorista motorista in this.motoristas
                where motorista.Id == id
                select motorista;
            MostrarMotoristasDisponiveis();
            while(pessoa == null)
            {
                Console.WriteLine("Digite o ID do motorista: ");
                id = Convert.ToInt32(Console.ReadLine());
                foreach(var motorista in motoristaQuery)
                {
                    pessoa = motorista;
                }           
            }
            return pessoa;
        }
        private int BuscarIndiceCaminhao()
        {
            int idCaminhao = 0;
            int indice = -1;
            var caminhaoQuery =
                  from Caminhao caminhao in this.caminhoes
                  where caminhao.Id == idCaminhao
                  select caminhao;
            while(indice == -1)
            {
                Console.WriteLine("Digite o id do caminhão a ser atualizado: ");
                idCaminhao = Convert.ToInt32(Console.ReadLine());
                foreach (var caminhao in caminhaoQuery.Select((value, i) => new { i, value }))
                {
                    indice = caminhao.i;
                }
            }  
            return indice;
        }
        private int BuscarIndiceMotorista()
        {
            int idMotorista = 0;
            int indice = -1;
            var motoristaQuery =
                from Motorista motorista in this.motoristas
                where motorista.Id == idMotorista
                select motorista;
            while(indice == -1)
            {
                Console.WriteLine("Digite o Id do motorista a ser atualizado: ");
                idMotorista = Convert.ToInt32(Console.ReadLine());
                foreach(var motorista in motoristaQuery.Select((value, i) => new { i, value }))
                {
                    indice = motorista.i;
                }       
            }
            return indice;
        }
        private int BuscarIndiceViagem()
        {
            int idViagem = 0;
            int indice = -1;
            var viagensQuery =
                from Viagem viagens in this.viagens
                where viagens.Id == idViagem
                select viagens;
            while(indice == -1)
            {
                Console.WriteLine("Digite o ID da viagem a ser atualizada: ");
                idViagem = Convert.ToInt32(Console.ReadLine());
                foreach(var viagens in viagensQuery.Select((value, i) => new { i, value }))
                {
                    indice = viagens.i;
                }
            }
            return indice;
        } 
    }
}
    
