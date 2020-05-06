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
    }
}