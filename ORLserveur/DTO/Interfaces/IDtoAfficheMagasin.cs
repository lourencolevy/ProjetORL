using ORLserveur.DTO.Interfaces.InterfacesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORLserveur.DTO.Interfaces
{
    /// <summary>
    /// Une class DTO qui stocke des données concernant les magasins.
    /// On utilise cet class pour transferer les données 
    /// de la couche Metier vers les controleurs.
    /// 
    /// 
    /// </summary>
    interface IDtoAfficheMagasin : IDtoEnseigne, IDtoMagasin
    {
        //Exemple

         int IdMagasin {get;set;}
    }
}
