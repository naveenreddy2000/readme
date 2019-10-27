// C# ram to find LCM of Fib(a) 
// and Fib(b) 
using System; 

class GFG 
{ 

static int MAX = 1000; 

// Create an array for memoization 
static int[] f = new int[MAX]; 

// Function to return the n'th Fibonacci 
// number using table f[]. 
static int fib(int n) 
{ 
	// Base cases 
	if (n == 0) 
		return 0; 
	if (n == 1 || n == 2) 
		return (f[n] = 1); 

	// If fib(n) is already computed 
	if (f[n] != 0) 
		return f[n]; 
	int k = 0; 
	if ((n & 1) != 0) 
		k = (n + 1) / 2; 
	else
		k = n / 2; 

	// Applying recursive formula 
	// Note value n&1 is 1 
	// if n is odd, else 0. 
	if((n & 1 ) != 0) 
		f[n] = (fib(k) * fib(k) + 
				fib(k - 1) * fib(k - 1)); 
	else
		f[n] = (2 * fib(k - 1) + 
					fib(k)) * fib(k); 

	return f[n]; 
} 

// Function to return gcd of a and b 
static int gcd(int a, int b) 
{ 
	if (a == 0) 
		return b; 

	return gcd(b % a, a); 
} 

// Function to return the LCM of 
// Fib(a) and Fib(a) 
static int findLCMFibonacci(int a, int b) 
{ 
	return (fib(a) * fib(b)) / fib(gcd(a, b)); 
} 

// Driver code 
static void Main() 
{ 
	int a = 3, b = 12; 

	Console.WriteLine(findLCMFibonacci(a, b)); 
} 
} 

// This code is contributed by mits 
