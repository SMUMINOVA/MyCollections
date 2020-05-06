using System.Collections.Generic;
namespace Collection
{
    public class MyList<T>
    {
        public MyList(){
            list = new T[0];
        }
        public T[] list;
        public int Length{
            get{
                return list.Length;
            }
        }
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
        public IEnumerable<T> GetAll(int max){
            for (int i = 0; i < max; i++){
                if(i == list.Length){
                    yield break;
                }
                else{
                    yield return list[i];
                }
            }
        }
        public void Add(T[] arr){
            int j = 0;
            T[] nList = new T[list.Length + arr.Length];
            for(j = 0; j < list.Length; j++)
                nList[j] = list[j];
            for(int i = 0; i < arr.Length; i++)
                nList[j] = arr[i];         
            list = nList;
        }      
        public void Insert(int index, T item){
            T[] nList = new T[list.Length + 1];
            for(int i = 0; i < index; i++)
                nList[i] = list[i];
            nList[index] = item;
            for(int i = index; i < list.Length; i++)
                nList[i] = list[i];
            list = nList;
        } 
    }
}