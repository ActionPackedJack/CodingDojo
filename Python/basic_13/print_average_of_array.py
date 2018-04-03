def print_average_of_array(arr):
    sum=0
    for i in range(len(arr)):
        sum+=arr[i]
    print(sum/len(arr)+sum%len(arr))

print_average_of_array([12,15,17,17,17.5])