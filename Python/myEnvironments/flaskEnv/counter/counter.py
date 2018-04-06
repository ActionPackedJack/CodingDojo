from flask import Flask, render_template, redirect, request, session

app = Flask(__name__)
app.config['SECRET_KEY']='blormp'

@app.route("/")

def home():
    if 'num' in session:
        session['num']+=1
    else:
        session['num'] = 0
    num = session['num']
    return render_template("index.html")

@app.route("/reset")

def reset():
    session['num'] = -1
    return redirect("/")

@app.route("/reload")
def refresh():
    session['num']+=1
    return redirect("/")
app.run(debug=True)