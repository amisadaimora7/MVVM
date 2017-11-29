using Estados.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estados.ViewModel
{
    class EstadosViewModel : ViewModelBase
    {
        ObservableCollection<Estado> estados;
        ObservableCollection<Municipio> municipios;
        ObservableCollection<Localidad> localidades;
        Estado estadoSeleccionado;
        Municipio municipioSeleccionado;

        public EstadosViewModel() {
            this.estados = new ObservableCollection<Estado>();
            MunicipiosEntities DB = new MunicipiosEntities();
            var estaditos = DB.Estado.All();
        }

        public ObservableCollection<Estado> Estados
        {
            get { return estados; }
            set
            {
                estados = value;
                OnPropertyChanged("Estados");
            }
        }
        public ObservableCollection<Municipio> Municipios
        {
            get { return municipios; }
            set
            {
                municipios = value;
                OnPropertyChanged("Municipios");
            }
        }
        public ObservableCollection<Localidad> Localidades
        {
            get { return localidades; }
            set
            {
                localidades = value;
                OnPropertyChanged("Localidades");
            }
        }

        public Estado EstadosSeleccionado {
            get { return estadoSeleccionado; }
            set { estadoSeleccionado = value;
                Municipios = new ObservableCollection<Municipio>(estadoSeleccionado.Municipio);
                OnPropertyChanged("EstadoSeleccionado");
            }
        }


     }
 }