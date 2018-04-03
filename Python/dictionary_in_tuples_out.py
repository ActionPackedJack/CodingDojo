my_dict = {
  "Speros": "(555) 555-5555",
  "Michael": "(999) 999-9999",
  "Jay": "(777) 777-7777"
}

def dictionary_in_tuples_out(dict):
    result=[]
    print dict.items()
    #for key,data in dict.items():
        #result.append(zip(key,data))
    #print result
dictionary_in_tuples_out(my_dict)