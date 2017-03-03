Potrebno je kao prvo uključiti namespace System.Runtime i System.Runtime.InteropSevices
    /// 
    /// Preko [DllImport("wininet.dll")]  
    /// private static extern bool InternetGetConnectedState(out int description,int reservedValue);
    /// 
    /// definišemo koja će metoda iz wininet.dll biti pozvana 
    /// metoda mora biti static kao i to da sa extern označavamo da metoda dolazi iz spolja a ne iz naše app
    /// 
    /// -------------------------------------------------------------------------------------------------------
    /// Definicija za extern modifier:
    /// The extern modifier is used to declare a method that is implemented externally. 
    /// A common use of the extern modifier is with the DllImport attribute when you are using Interop services 
    /// to call into unmanaged code.
    /// 
    ///       private static extern metodaDllModulaKojaNasZanima
    /// -------------------------------------------------------------------------------------------------------
    /// 
    /// wininet.dll je modul koji sadrži funkcije vezane za Internet  a njih koriste Windows applikacije. 
    /// Spisak finkcija se može naći na 
    /// https://source.winehq.org/WineAPI/wininet.html
