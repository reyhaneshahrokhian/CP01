#include <iostream>
#include <bits/stdc++.h>

#define int long long

using namespace std;

int32_t main()
{
    int n,q;
    cin >> n >> q;
    int arr[n];
    vector<int> dp(n, 0);
    for(int i = 0; i < n; i++) cin>> arr[i];
    dp[0] = arr[0];
    for(int i = 1; i < n; i++) dp[i]=dp[i - 1] + arr[i];
    for(int i =0; i < q; i++){
        int query;
        cin >> query; 
        if(query> dp[n - 1]) cout<< "-1" << endl;
        else{
            auto lower = lower_bound(dp.begin(), dp.end(), query);
            cout << distance(dp.begin(), lower) + 1 << endl;
        }
    }
    return 0;
}
