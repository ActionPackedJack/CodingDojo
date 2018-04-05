from flask import Flask, render_template, request
app = Flask(__name__)

@app.route('/')
def openpage():
    return render_template('root.html')

@app.route('/projects')
def openProjects():
    return render_template('projects.html')

@app.route('/about')
def openAbout():
    return render_template('about.html')

app.run(debug=True)
