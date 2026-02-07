import {useState} from 'react';
import {createRoot} from 'react-dom/client';


function BugForm() {
 const [title, setTitle] = useState('');
 const [description, setDescription] = useState('');
 const [severity, setSeverity]=useState('Low');
 const [status, setStatus]=useState('Open');

 function handleChangeTitle(e){
  setTitle(e.target.value);
 }

 function handleChangeDescription(e){
  setDescription(e.target.value);
 }

 function handleChangeStatus(e){
  setStatus(e/target.value);
 }

 function handleChangeSeverity(e){
  setSeverity(e.target.value);
 }

 //habling submit
 function handleSubmit(e){
  e.preventDefault();
  console.log((('Form submitted with title: ') + title));
  console.log((('Form submitted with description: ') + description));
  console.log((('Form submitted with severity: ') + severity));
  console.log((('Form submitted with status: ') + status));
 }
 
  return (
   <>
    <h1 className="heading-4">Create a New Bug</h1>
    <form>
      {/* // Title Input   */}
      <div className='form-group'>
         <label >Enter your title: 
            <input className="form-control" type="text" value={title} onChange={handleChangeTitle} />
          </label>
      </div>

      {/* // Description Input   */}
      <div className='form-group'>
         <label >Description 
          <textarea className="form-control" type="text" value={description} onChange={handleChangeDescription}>  </textarea>
          </label>
      </div>

      {/* Severity dropdown */}
      <div className='form-group'>
        <label>Severity
          <select value={severity} onChange={handleChangeSeverity} className='form-control'>
            <option value="Low">Low</option>
            <option value="Medium">Medium</option>
            <option value="High">High</option>
          </select>
        </label>
      </div>

      {/* Status dropdown */}
      <div className='form-group'>
        <label>Status
          <select value={status} onChange={handleChangeStatus} className='form-control'>
            <option value="Open">Open</option>
            <option value="In Progress">In Progress</option>
            <option value="Closed">Closed</option>
          </select>
        </label>
      </div>
     
      <div className='form-group'>
        <label>
         <button className='btn btn-primary btn-sm' type="button" value='Submit' onClick={handleSubmit}>Submit</button>
        </label>
      </div>
      
      
    </form>
   </>
  );
}

export default BugForm;