Console.Write("Quantas pontuações? ");             // Pergunta quantas pontuações serão inseridas
int n = int.Parse(Console.ReadLine());              // Lê e converte a quantidade para inteiro
int[] v = new int[n];                                // Cria o array com o tamanho informado

for (int i = 0; i < n; i++)                          // Loop para ler cada pontuação
{
    Console.Write($"Pontuação #{i + 1}: ");          // Pede a pontuação atual
    v[i] = int.Parse(Console.ReadLine());             // Lê e armazena no array
}

QuickSort(v, 0, n - 1);                              // Chama Quick Sort para ordenar o array

Console.WriteLine("\nRanking ordenado:");           // Mensagem antes de imprimir o resultado
for (int i = 0; i < n; i++)                          // Loop para imprimir cada pontuação ordenada
    Console.WriteLine(v[i]);                         // Imprime a pontuação na tela

static void QuickSort(int[] a, int l, int r)
{
    if (l < r)                                           // Verifica se o segmento tem mais de 1 elemento
    {
        int p = Particionar(a, l, r);                    // Faz a partição e retorna o pivô
        QuickSort(a, l, p - 1);                          // Ordena a parte esquerda do pivô
        QuickSort(a, p + 1, r);                          // Ordena a parte direita do pivô
    }
}

static int Particionar(int[] a, int l, int r)
{
    int pivo = a[r], i = l - 1;                          // Escolhe pivô e inicializa índice i
    for (int j = l; j < r; j++)                          // Percorre do início até o penúltimo elemento
        if (a[j] > pivo)                                 // Se elemento maior que pivô (ordem decrescente)
            Trocar(a, ++i, j);                           // Troca elementos para manter a ordem
    Trocar(a, i + 1, r);                                 // Coloca pivô na posição correta
    return i + 1;                                        // Retorna posição do pivô
}

static void Trocar(int[] a, int i, int j)
{
    int temp = a[i];                                     // Salva temporariamente valor em a[i]
    a[i] = a[j];                                         // Coloca valor de a[j] em a[i]
    a[j] = temp;                                         // Coloca valor salvo em a[j]
}