import express from 'express';
import cors from 'cors';
const app = express();
const PORT = 4000;
import event from './Controllers/event.js';
import eventProducer from './Controllers/eventProducer.js';

const router = express.Router({ mergeParams: true });

import bodyParser from 'body-parser';
app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: false }))
app.use(cors());
app.use((req, res, next) => {
    console.log(`${req.method} request for '${req.url}'`);
    next();
});

app.use('/',event);
app.use('/',eventProducer);

app.use((err, req, res, next) => {
    console.error(err.stack)
    res.status(500).send('Something broke!')
  })

app.listen(PORT, (error) =>{
    if(!error)
        console.log("Server is Successfully Running, and App is listening on port" + PORT)
    else 
        console.log("Error occurred, server can't start", error);
    }
);