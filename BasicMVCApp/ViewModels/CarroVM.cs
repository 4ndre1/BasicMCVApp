using System;

namespace BasicMVCApp.ViewModels
{
    public class CarroVM
    {
        public int Id { get; set; }
        public String Marca { get; set; }
        public String Nome { get; set; }
        public String Trim { get; set; }
        public int Ano { get; set; }
        public String Corpo { get; set; }
        public String MotorPosicao { get; set; }
        public int MotorCC { get; set; }
        public int MotorCilindro { get; set; }
        public String MotorTipo { get; set; }
        public int MotorValPorCil { get; set; }
        public int MotorForcaPS { get; set; }
        public int MotorForcaRPM { get; set; }
        public int MotorTorqueNM { get; set; }
        public int MotorTorqueRPM { get; set; }
        public String MotorBoreMM { get; set; }
        public String MotorStrokeMM { get; set; }
        public String MotorCompressao { get; set; }
        public String MotorCombustivel { get; set; }
        public String TopSpeedKPH { get; set; }
        public String OTo100KPH { get; set; }
        public String Direcao { get; set; }
        public String Transmissao { get; set; }
        public int Assentos { get; set; }
        public int Portas { get; set; }
        public int PesoKG { get; set; }
        public int ComprimentoMM { get; set; }
        public int LarguraMM { get; set; }
        public int TamanhoMM { get; set; }
        public int WheelBase { get; set; }
        public Double lKMHWY { get; set; }
        public String lKMMixed { get; set; }
        public Double lKMCity { get; set; }
        public int FuelCapL { get; set; }
        public int SoldInUs { get; set; }
        public String MarcaAExibir { get; set; }
    }
}