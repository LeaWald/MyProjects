import mongoose from 'mongoose'
const { Schema, model } = mongoose;
mongoose.connect('mongodb://localhost:27017/event')
.then(() => console.log('Connected to MongoDB'))
.catch(err => console.error('Could not connect to MongoDB:', err));


const producerSchema = new Schema({
    name:String,
    email:{type: String,required: true,unique: true},
    phone:String,
    description:String
  });

  const Producer = model('Producer', producerSchema);
  export default Producer;