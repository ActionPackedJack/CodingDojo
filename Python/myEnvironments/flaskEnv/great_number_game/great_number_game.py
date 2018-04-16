from flask import Flask, render_template, redirect, request, session
import random

app = Flask(__name__)
app.secret_key='blormp'

@app.route("/")
def home():
    session['answer']= int(random.randint(0,101))
    #print session['answer']
    return render_template("home.html")

@app.route("/users", methods=["POST"])
def evaluateCorrectness():
    session['guess']=int(request.form['guess'])
    if session['guess']>session['answer']:
        result="TOO HIGH"
    if session['guess']<session['answer']:
        result="TOO LOW"
    if session['guess']==session['answer']:
        result=str(session['answer'])+ " WAS THE ANSWER!"
    return result

app.run(debug=True)