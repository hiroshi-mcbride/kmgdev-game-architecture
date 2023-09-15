public delegate void SomeDelegate(string _what);

public class WhatToDoWithDelegate
{
    public event SomeDelegate Yeah;

    public WhatToDoWithDelegate()
    {
        
    }
    
    private void SomeMethod(string _what)
    {
        Yeah?.Invoke(_what);
    }
}
