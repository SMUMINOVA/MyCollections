using System.Collections.Generic;
namespace Collection
{
    public class MyDictionary<TKey, TValue>
    {
        public TKey[] key{get;set;}
        public TValue[] dictionary{get;set;}
        public int Length{
            get{
                return key.Length;
            }
        }
        public MyDictionary(){
            key = new TKey[0];
            dictionary = new TValue[0];
        }
        public void Add(TKey k, TValue val){
            TKey[] newKey = new TKey[key.Length + 1];
            TValue[] newValue = new TValue[dictionary.Length + 1];
            for(int i = 0; i < key.Length; i++){
                newKey[i] = key[i];
                newValue[i] = dictionary[i]; 
            }
            newKey[key.Length] = k;
            newValue[dictionary.Length] = val;
            key = newKey;
            dictionary = newValue;
        }
        public TValue GetElement(TKey k){
            int i = 0;
            for(i = 0; i < key.Length; i++){
                if ((object)key[i] == (object)k){
                    break;
                }
            }
            return dictionary[i];
        }
        public IEnumerable<TValue> GetAll(int max){
            for (int i = 0; i < max; i++){
                if(i == dictionary.Length){
                    yield break;
                }
                else{
                    yield return dictionary[i];
                }
            }
        } 
    }
}