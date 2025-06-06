//*****************************************************************************
//** 2434. Using a Robot to Print the Lexicographically Smallest String      **
//*****************************************************************************

char* robotWithString(char* s) {
    int n = strlen(s), freq[26] = {0}, top = -1;
    for (int i = 0; i < n; i++) freq[s[i] - 'a']++;
    char *res = malloc(n + 1), *stk = malloc(n), min;
    for (int i = 0, j = 0, c = 0; i < n || top >= 0; )
    {
        while (i < n) {
            stk[++top] = s[i]; freq[s[i++] - 'a']--;
            while (c < 26 && !freq[c]) c++;
            if (stk[top] <= 'a' + c) break;
        }
        while (top >= 0 && stk[top] <= 'a' + c) res[j++] = stk[top--];
    }
    return res[n] = 0, res;
}