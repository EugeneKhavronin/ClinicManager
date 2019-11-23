import React from 'react';
import ReactDOM from 'react-dom';
import { Form, Field } from 'react-final-form';
import { TextField, Checkbox, Radio, Select } from 'final-form-material-ui';
import {
    Typography,
    Paper,
    Link,
    Grid,
    Button,
    CssBaseline,
    RadioGroup,
    FormLabel,
    MenuItem,
    FormGroup,
    FormControl,
    FormControlLabel,
} from '@material-ui/core';

const onSubmit = async values => {
    const sleep = ms => new Promise(resolve => setTimeout(resolve, ms));
    await sleep(300);
    window.alert(JSON.stringify(values, 0, 2));
};

function EditForm() {
    return (
        <div style={{ padding: 16, margin: 'auto', maxWidth: 600 }}>
            <CssBaseline />
            <Form
                onSubmit={onSubmit}
                initialValues={{ employed: true, stooge: 'larry' }}
                render={({ handleSubmit, reset, submitting, pristine, values }) => (
                    <form onSubmit={handleSubmit} noValidate>
                        <Paper style={{ padding: 16 }}>
                            <Grid container alignItems="flex-start" spacing={2}>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="Возраст"
                                        component={TextField}
                                        type="text"
                                        label="Возраст"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="sex"
                                        component={TextField}
                                        type="text"
                                        label="Пол"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="type"
                                        component={TextField}
                                        type="text"
                                        label="Тип боли в груди"
                                    />
                                </Grid>
                                <Grid item xs={12}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Артериальное давление в состоянии покоя"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Холесторальная сыворотка"
                                    />
                                </Grid>
                                <Grid item xs={12}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Уровень сахара в крови натощак"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Результат электрокардиографии"
                                    />
                                </Grid>
                                <Grid item xs={12}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Max частота сердечных сокращений"
                                    />
                                </Grid>
                                <Grid item xs={12}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Стенокардия, вызванная физической нагрузкой"
                                    />
                                </Grid>
                                <Grid item xs={12}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Дисперсия при физических упражнениях относительно отдыха"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Наклон пика сегмента"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Количество крупных сосудов"
                                    />
                                </Grid>
                                <Grid item xs={6}>
                                    <Field
                                        fullWidth
                                        required
                                        name="art"
                                        component={TextField}
                                        type="text"
                                        label="Диагноз болезни сердца"
                                    />
                                </Grid>

                                <Grid item style={{ marginTop: 16 }}>
                                    <Button
                                        variant="contained"
                                        color="primary"
                                        type="submit"
                                        disabled={submitting}
                                    >
                                        Вычислить
                                    </Button>
                                </Grid>
                            </Grid>
                        </Paper>
                    </form>
                )}
            />
        </div>
    );
}
export default EditForm;
