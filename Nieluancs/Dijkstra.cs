using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nieluancs
{
    class Dijkstra
    {
        private List<List<int>> M; //danh sach canh ke
        private List<List<int>> value; //danh sach trong so
        private List<int> p = new List<int>();
        private int ValueAdj; // trong so tren cung
        public Dijkstra(List<List<int>> adj, List<List<int>> Vlue)
        {
            this.M = adj;
            this.value = Vlue;
        }
        public List<int> Mooredijkstra(int Vertices, int start, int end)
        {           
            int u;
            int[] pi = new int[Vertices+1];
            int[] mark = new int[Vertices+1];
            
            int[] pre = new int[Vertices+1];
            for (u = 0; u < pi.Length; u++)
            {
                pi[u] = 9999;
                mark[u] = -2;
                pre[u] = -1;
            }
            pi[start] = 0;
            for (int k = 0; k < pi.Length; k++)
            {
                int min_pi = 9999;
                for (int j = 0; j < pi.Length; j++)
                {
                    if (mark[j] == -2 && pi[j] < min_pi)
                    {
                        min_pi = pi[j];
                        u = j;
                    }
                }
                mark[u] = 1;
                List<int> row = new List<int>(this.M[u]);
                List<int> rowvalue = new List<int>(this.value[u]);
                if (row != null)
                {
                    foreach (int col in row)
                    {
                        foreach (int colvalue in rowvalue)
                        {
                            rowvalue.Remove(colvalue);
                            if (mark[col] == -2){
                                if (pi[u] + colvalue < pi[col]){
                                   pi[col] = pi[u] + colvalue;
                                   pre[col] = u;
                                   break;
                                }
                                else{
                                    break;
                                }
                            }
                            else{
                                break;
                            }
                        }                        
                    }
                }
            }
            int current = end;
            this.p.Add(end);
            while (pre[current] != -1)
            {
                this.p.Add(pre[current]);
                current = pre[current];
            }
            this.p.Reverse();

            return this.p;
        }
        public int ValueDijkstra(int Vertices, int start, int end) // truy vet trong so tren duong di
        {

            int u;
            int[] pi = new int[Vertices+1];
            int[] mark = new int[Vertices+1];
            int[] pre = new int[Vertices+1];
            for (u = 0; u < pi.Length; u++)
            {
                pi[u] = 999999;
                mark[u] = -2;
                pre[u] = -1;
            }
            pi[start] = 0;
            for (int k = 0; k < pi.Length; k++)
            {
                int min_pi = 9999;
                for (int j = 0; j < pi.Length; j++)
                {
                    if (mark[j] == -2 && pi[j] < min_pi)
                    {
                        min_pi = pi[j];
                        u = j;
                    }
                }
                mark[u] = 1;
                List<int> row = new List<int>(this.M[u]);
                List<int> rowvalue = new List<int>(this.value[u]);
                if (row != null)
                {
                    foreach (int col in row)
                    {
                        foreach (int colvalue in rowvalue)
                        {
                            rowvalue.Remove(colvalue);//xoa phan tu khoi list
                            if (mark[col] == -2)
                            {
                                if (pi[u] + colvalue < pi[col])
                                {
                                    pi[col] = pi[u] + colvalue;
                                    pre[col] = u;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            this.ValueAdj = pi[end];
            return this.ValueAdj;
        }
    }
}

        





