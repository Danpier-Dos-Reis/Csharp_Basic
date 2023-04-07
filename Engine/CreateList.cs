using Listas.Modelo;

namespace Listas.Engine
{
    public class CreateList
    {
        public List<Pais> GetList(){

            Random random = new Random();
                int gastopublico = random.Next(100000000,700000000);
                int anniofundacion = random.Next(1800,2000);

            var paises = new List<Pais>{
                new Pais{
                    Nombre="Canadá",Presidente="Justin Truedou",Gentilisio="Canadienses",Religion="Ninguna",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{
                    Nombre="Estados Unidos",Presidente="Joe Biden",Gentilisio="Estadounidenses",Religion="Droga",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{
                    Nombre="México",Presidente="AMLO",Gentilisio="Mexicanos/as",Religion="Católica",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{
                    Nombre="Brasil",Presidente="Lula Da Silva",Gentilisio="Brasileños/as",Religion="Ninguna",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{Nombre="Argentina",Presidente="Alberto Fenardez",Gentilisio="Argentinos/as",Religion="Futbol",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{Nombre="Chile",Presidente="Gabriel Borics",Gentilisio="Chilenos/as",Religion="Futbol",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{Nombre="Uruguay",Presidente="Luis Alberto Lacalle Pou",Gentilisio="Uruguayos/as",Religion="Futbol",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{Nombre="Iran",Presidente="Hassan Rouhani",Gentilisio="Iranís",Religion="Islam",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{Nombre="Pakistán",Presidente="Arif Alvi",Gentilisio="Pakitanís",Religion="Islam",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                },
                new Pais{Nombre="China",Presidente="Xi Jinping",Gentilisio="Chinos/as",Religion="Budaismo",GastoPublico=gastopublico,AnnioFundacion=anniofundacion
                }
            };
            return paises.ToList();
        }
    }
}