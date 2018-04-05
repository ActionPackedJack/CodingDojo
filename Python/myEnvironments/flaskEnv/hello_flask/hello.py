from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/')

def hello_world():
    return 'Hello World!'

@app.route('/success')
def success():
  return redirect('/')
app.run(debug=True)