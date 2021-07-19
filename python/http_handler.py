from flask import Flask, flash, request, url_for, send_from_directory, redirect
import os
from werkzeug.utils import  secure_filename
from detection_service import DetectionService
import uuid
import config

app = Flask(__name__)
detection_service = DetectionService()

if not os.path.exists(config.UPLOAD_FOLDER):
    os.mkdir(config.UPLOAD_FOLDER)

def allowed_file(filename):
    return '.' in filename and \
           filename.rsplit('.', 1)[1].lower() in config.ALLOWED_EXTENSIONS

@app.route('/detections/<resource_name>', methods=['GET'])
def uploaded_file(resource_name):
    dir_name = resource_name.rsplit('.')[0]
    extension = "." + resource_name.rsplit('.')[1]
    return send_from_directory(config.UPLOAD_FOLDER + "/" + dir_name,
                               config.DETECTED_FILE_NAME + extension)

@app.route('/detections/', methods=['POST'])
def file_upload():
    parent_dir = config.UPLOAD_FOLDER
    new_name = str(uuid.uuid1())
    path = os.path.join(parent_dir, new_name)
    os.mkdir(path)
    print("Directory '% s' created" % path)

    if request.method == 'POST':
        # check if the post request has the file part
        if 'file' not in request.files:
            flash('No file part')
            return redirect(request.url)
        file = request.files['file']
        # if user does not select file, browser also
        # submit an empty part without filename
        if file.filename == '':
            flash('No selected file')
            return redirect(request.url)
        if file and allowed_file(file.filename):
            filename = secure_filename(file.filename)
            full_new_image_path = os.path.join(path, filename)
            file.save(full_new_image_path)
            detection_service.detect(full_new_image_path)
        extension = "." + full_new_image_path.rsplit('.')[1]
        return config.FILE_ACCESS_ADDRESS + url_for('uploaded_file', resource_name=new_name + extension)


if __name__ == '__main__':
    app.run(debug=True)