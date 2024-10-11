using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Estacionamento.models
{
    public class Estacionamento
    {
        public double ValorFixo { get; set; }
        public int HorasEstacionadas { get; set;}
        public List<string> Veiculos { get; set; }

        public void AddVeicles(string newVeicle) {
            Veiculos.Add(newVeicle);
            Console.Clear();
            Console.WriteLine("Veículo Adicionado com Sucesso!");
        }
        public void RemoveVeicles(string veicleRemoved){
            if(Veiculos.Contains(veicleRemoved)){
                Console.Clear();
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou no estacionamento");
                double hours = Convert.ToDouble(Console.ReadLine());
                Veiculos.Remove(veicleRemoved);
                Console.WriteLine($"Total a pagar: {ValorFixo + (HorasEstacionadas * hours)}");
            } else{
                Console.Clear();
                Console.WriteLine("Veículo não se encontra no estacionamento");
            }
        }
        public void ShowVeicles(){
            if(Veiculos.Count <= 0){
                Console.Clear();
                Console.WriteLine("Não há veículos no estacionamento");
            } else {
                Console.Clear();
                foreach(var veicle in Veiculos){
                Console.WriteLine(veicle);
                }
            }
        }

        public int CloseApp() { return 0; }
    }
}