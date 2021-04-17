using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Facade
{
    public class HomeTheaterFacade
    {
        private readonly IMaquinaPipoca _maquinaPipoca;
        private readonly ITela _tela;
        private readonly ILuzAmbiente _luzAmbiente;
        private readonly IProjetor _projetor;
        private readonly IAmplificador amplificador;
        private readonly IDvdPlayer dvdPlayer;

        public HomeTheaterFacade(IMaquinaPipoca maquinaPipoca,
                                 ITela tela,
                                 ILuzAmbiente luzAmbiente,
                                 IProjetor projetor,
                                 IAmplificador amplificador,
                                 IDvdPlayer dvdPlayer)
        {
            _maquinaPipoca = maquinaPipoca;
            _tela = tela;
            _luzAmbiente = luzAmbiente;
            this._projetor = projetor;
            this.amplificador = amplificador;
            this.dvdPlayer = dvdPlayer;
        }
        public void VerFilme(string filme)
        {
            Console.WriteLine($"Preparando ambiente para ver filme {filme}");
            _maquinaPipoca.On();
            _maquinaPipoca.Fazer();

            _luzAmbiente.Dim();

            _tela.Down();

            _projetor.On();
            _projetor.WideScreenMode();
            this.amplificador.On();
            this.amplificador.SetDvd(this.dvdPlayer);
            this.amplificador.SetSurroundSound();
            this.amplificador.SetVolume(5);
            this.dvdPlayer.On();
            this.dvdPlayer.Play(filme);

        }

        public void FinalizarFilme()
        {
            Console.WriteLine($"Desligando filme");
            _maquinaPipoca.Off();
            
            _luzAmbiente.On();

            _tela.Up();

            _projetor.Off();            
            this.amplificador.Off();
            this.dvdPlayer.Stop();
            this.dvdPlayer.Eject();
            this.dvdPlayer.Off();
        }
    }
}
