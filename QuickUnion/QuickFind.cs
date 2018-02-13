namespace UnionFind
{
    public class QuickFind
    {   //indexes are the sites, N sites total
        //values at each index point to parent index, leading to the root
        private int[] _arr;
        private int _count;

        public QuickFind(int N)
        {
            _count = N;
            _arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                _arr[i] = i;
            }
        }
        public void Union(int p, int q) { 
            int pVal = Find(p);
            int qVal = Find(q);
            if (pVal != qVal)
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    if (_arr[i] == pVal)
                    {
                        _arr[i] = qVal;
                        
                    }

                }
                _count--;
            }
            

        }

        public int Find(int p)
        {
            return _arr[p];
        }

        public bool IsConnected(int p, int q)
        {
            return (Find(p) == Find(q));
        }

        public int Count()
        {
            return _count;
        }




    }
}
