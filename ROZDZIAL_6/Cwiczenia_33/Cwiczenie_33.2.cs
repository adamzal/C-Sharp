using System;

class Zewnetrzna
{
    private class Wewnetrzna
    {       
    }
    public Wewnetrzna create()
    {
        return new Wewnetrzna(); //Błąd dostępu    
    }
}
