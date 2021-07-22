from keras_retinanet import models
from keras_retinanet.utils.image import read_image_bgr, preprocess_image, resize_image
from keras_retinanet.utils.visualization import draw_box, draw_caption
from keras_retinanet.utils.colors import label_color

# import other modules
import matplotlib.pyplot as plt
import cv2
import numpy as np
import time
import config
import uuid

class DetectionService:

    def __init__(self):

        # retrained_model_path = os.path.join('resnet50_csv_50.h5')
        self.retrained_model_path = config.MODEL_PATH
        # loading retinanet model
        self.retrained_model = models.load_model(self.retrained_model_path, backbone_name='resnet50')
        self.retrained_model = models.convert_model(self.retrained_model)
        print("Instance created")

    def detect(self, original_image_path):
        # load label to names mapping for visualization purposes
        labels_to_names = {0: ''}

        # load image
        image = read_image_bgr(original_image_path)

        # copy to draw on
        draw = image.copy()
        draw = cv2.cvtColor(draw, cv2.COLOR_BGR2RGB)

        # preprocess image for network
        image = preprocess_image(image)
        image, scale = resize_image(image)

        # process image
        start = time.time()
        boxes, scores, labels = self.retrained_model.predict_on_batch(np.expand_dims(image, axis=0))
        print("processing time: ", time.time() - start)

        # correct for image scale
        boxes /= scale

        # visualize detections
        for box, score, label in zip(boxes[0], scores[0], labels[0]):
            # scores are sorted so we can break
            if score < config.DETECTION_CONFIDENCE_THRESHOLD:
                break

            color = label_color(label)

            b = box.astype(int)
            draw_box(draw, b, color=color)
            caption = "{} {:.3f}".format(labels_to_names[label], score)
            draw_caption(draw, b, caption)

        """
        base_path = "C:\\requested_files\\"
        base_name = os.path.basename(original_image_path)

        base_path = "C:\\savenewimages\\"
        extension = os.path.splitext(base_name)[1]
        new_file_name = str(uuid.uuid1())
        new_image_path = base_path + new_file_name + extension
        """
        extension = "." + str(original_image_path).rsplit('.')[1]
        last_slash_index = str(original_image_path).rfind('\\')
        save_directory = str(original_image_path)[0:last_slash_index]
        new_image_path = save_directory + "/" + config.DETECTED_FILE_NAME + extension
        plt.imsave(new_image_path, draw)