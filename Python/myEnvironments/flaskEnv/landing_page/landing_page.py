from flask import Flask, render_template, request
app = Flask(__name__)

@app.route('/')
def openpage():
    return render_template('index.html')

@app.route('/ninja')
def openProjects():
    return render_template('ninja.html')

@app.route('/dojos/new' )
def openAbout():
    return render_template('dojos.html')

app.run(debug=True)