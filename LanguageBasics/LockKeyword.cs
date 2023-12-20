using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
/*
 
 The lock keyword in C# plays a crucial role in achieving thread safety within multithreaded applications. It helps control access to shared resources and prevents data corruption caused by concurrent manipulation.

*** What does lock do?

lock acquires a mutual exclusion lock on a specified object. This means only one thread can enter the code block protected by the lock statement at a time.
Other threads attempting to enter the block will wait until the first thread finishes and releases the lock.
This ensures that the protected code can run without interference from other threads, preventing race conditions and data inconsistencies.
Example 1: Protecting a counter:

*** Key points to remember:

Use lock sparingly, as excessive locking can affect performance.
Choose the appropriate object to lock on, typically the shared resource being accessed.
Always release the lock once the protected code block is finished to avoid deadlock situations.
 
 */
namespace LanguageBasics
{
    internal class LockKeyword
    {
        object counterLock = new object(); // create a lock object

        int counter = 0;

        void IncrementCounter()
        {
            lock (counterLock) // acquire lock on counterLock object
            {
                counter++; // increment counter safely
            }
        }
        /* 
            Here, the lock statement ensures that only one thread can access 
            the counter variable at a time, guaranteeing its accurate value even with 
            multiple threads incrementing it.
        */

    }

    //Example 2: Synchronizing bank account access:



    class BankAccount
    {
        decimal balance;

        public void Deposit(decimal amount)
        {
            lock (this) // lock on current BankAccount object
            {
                balance += amount;
            }
        }

        public decimal GetBalance()
        {
            lock (this) // lock on current BankAccount object
            {
                return balance;
            }
        }
    }
    //In this example, the Bank class methods use
    //lock on the this object to protect the balance field.
    //This ensures that concurrent deposits or withdrawals happen synchronously,
    //preventing unexpected changes and invalid values.



}
