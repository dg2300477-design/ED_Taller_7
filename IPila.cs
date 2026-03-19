namespace EST_Master.Interfaces
{
    public interface IPila<T>
    {
        void Push(T data);    
        T Pop();             
        T Peek();            
        bool IsEmpty();      
        int Count();         
        void Clear();        
    }
}