using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDelegate.Delegates
{
    delegate bool Check(int reqem);
    //delegate bool Check(int reqem, double a);

    delegate TResult CustomGenericTypeDelegate<in T,out TResult>(T item);
    delegate TResult CustomGenericTypeDelegate<in T1,in T2, out TResult>(T1 item);

    delegate void Write(string str);

}
