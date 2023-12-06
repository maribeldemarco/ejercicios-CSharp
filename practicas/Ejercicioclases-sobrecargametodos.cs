
namespace Principal
{
    
    class Gatos {
        public bool vacunas;
        public int edad;
        public int id;
        public string nombre;
        public string dniduenio;
        public string nombreduenio;
        public string apellidoduenio;
        public string telefonoduenio;
        
        public Gatos (bool vacunas, int edad, int id, string nombre, string dniduenio, string nombreduenio, string apellidoduenio, string telefonoduenio) {
            this.vacunas= vacunas;
            this.edad= edad;
            this.id= id;
            this.nombre= nombre;
            this.dniduenio= dniduenio;
            this.nombreduenio= nombreduenio;
            this.apellidoduenio= apellidoduenio;
            this.telefonoduenio= telefonoduenio;
                    }
        
        
             public void SetDatosGato (bool vacunas, int edad){
             this.vacunas= vacunas;
             this.edad= edad;
            
            
        }
        
             public void SetDatosGato (int edad){
            this.edad= edad;
            
        }
              public void SetDatosGato (bool vacunas){
             this.vacunas= vacunas;
            
        }
        
               public void SetDatosDuenio (string nombreduenio, string apellidoduenio,string telefonoduenio){
               this.nombreduenio= nombreduenio;
               this.apellidoduenio= apellidoduenio;
               this.telefonoduenio= telefonoduenio;
            
        }
               public void SetDatosDuenio (string telefonoduenio){
               this.telefonoduenio= telefonoduenio;
            
        }
        
        
              public string MuestraDatos(){
              return  this.vacunas + " : vacunas \n"+ this.edad + "  : edad \n"+ this.id + ": legajo \n"+  this.nombre + ": nombre\n "+ this.dniduenio + ": dni dueño \n"+  nombreduenio + ": nombre del dueño  \n"+  this.apellidoduenio+ " : apellido del dueño\n"+  this.telefonoduenio + ": telefono del dueño \n\n";
            
        }
        
        
         
        
    }
    }
