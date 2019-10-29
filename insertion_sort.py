def sort(arr, n):
    for i in range(0, n):
        j = i
        while((j > 0) and arr[j] < arr[j - 1]):
            temp = arr[j - 1]
            arr[j - 1] = arr[j]
            arr[j] = temp
            j = j - 1
        
    return arr

print(sort(['I','N','S','E','R','T','I','O','N','S','O','R','T'], 13))