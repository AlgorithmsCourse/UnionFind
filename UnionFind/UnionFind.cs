namespace UnionFind
{
    public class UnionFind
    {   //indexes are the sites, N sites total
        //values at each index point to parent index, leading to the root
        private int[] _arr;
        private int _count;

        public UnionFind(int N)
        {
            _count = N;
            _arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                _arr[i] = i;
            }
        }
        public void Union(int p, int q)
        {   //find the root of int p
            var pr = Find(p);
            //find the root of int q
            var qr = Find(q);
            //if the roots are not equal then they are not connected
            if (pr != qr)
                //connect each root by setting root of p to root of q
                _arr[pr] = _arr[qr];
            _count--;
        }

        public int Find(int p)
        {
            //set the trial root to p
            int r = p;
            //check if is actually the root, if not reset the trial root to new value and repeat
            while (r != _arr[r])
            {
                r = _arr[r];
            }

            //when both numbers match, the root is found and return r as the root of queried int
            return r;
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
