#include<bits/stdc++.h>
using namespace std;
int n;
void dfs(int v)
{
    visited[v]=true;
    cout<<v<<" ";
    for(int i=0;i<adj[v].size();i++)
    {
        if(!visited[adj[v][i]])
        {
            dfs(adj[v][i]);
        }
    }
}
int main()
{
    cin>>n;
    adj.assing(n,vector<int>());
    visited.assing(n,false);
    int x,y;
    for(int i=0;i<n;i++)
    {
        cin>>x>>y;
        adj[x].push_back(y);
    }
    cout<<"list of elements"<<endl;
    for(int i=0;i<adj.size();i++)
    {
        for(int j=0;j<adj.size();j++)
        {
            cout<<adj[i][j]<<" ";
        }
        cout<<endl;
    }
    int s;
    cin>>s;
    dfs(s);
}