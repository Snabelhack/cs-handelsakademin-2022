namespace L03_Arrays;

static class Examples
{
    static bool[] EratosthenesSieve(int max)
    {
        return default;
    }
}

/*
algorithm Sieve of Eratosthenes is
    input: an integer n > 1.
    output: all prime numbers from 2 through n.

    let A be an array of Boolean values, indexed by integers 2 to n,
    initially all set to true.
    
for i = 2, 3, 4, ..., not exceeding √n do
    if A[i] is true
for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n do
    set A[j] := false

return all i such that A[i] is true.*/
