namespace Collection
{
    public class MyList<T>
    {
        public MyList(){
            list = new T[0];
        }
        public T[] list;
        public void Add(T item){
            T[] nList = new T[list.Length + 1];
            for(int i = 0; i < list.Length; i++)
                nList[i] = list[i];
            nList[list.Length] = item;
            list = nList;
        }
        public T GetElement(int index){
            return list[index];
        }
        
    }
}