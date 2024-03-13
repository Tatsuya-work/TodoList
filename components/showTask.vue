<template>
  <li v-for="(task, index) in prop.tasks" :key="index" class="task-list">
    <label class="task-line">
      <input v-model="task.ischeck" type="checkbox" class="checkbox" @change="onChangeCheck(index)" />
      <span class="dummy-checkbox" />
      <span :style="{ textDecoration: task.ischeck ? 'line-through' : 'none' }" class="task-name">
        {{ task.task }}
      </span>
    </label>
  </li>
</template>

<script setup lang="ts">
// Prop定義
const prop = defineProps<{
  tasks: {
    category: string;
    task: string;
    ischeck: boolean;
  }[];
}>();

// Emit定義
const emit = defineEmits<{
  (e: "onChange", index: number): void;
}>();
const onChangeCheck = (index: number): void => {
  emit("onChange", index);
};
</script>

<style scoped>
.task-list {
  list-style: none;
  padding-bottom: 5px;
}

.task-line {
  display: flex;
  align-items: center;
  gap: 7px;
  padding: 10px;
  cursor: pointer;
}

.task-line:hover {
  background: var(--background-gray);
}

.task-line:hover > .dummy-checkbox {
  transform: scale(1.1);
}

.checkbox {
  width: 0;
  opacity: 0;
}

.checkbox:checked + .dummy-checkbox {
  background: rgba(107, 26, 250, 1);
}

.checkbox:checked + .dummy-checkbox::before {
  content: "";
  display: block;
  position: absolute;
  top: 50%;
  left: 50%;
  width: 55%;
  height: 4px;
  border-radius: 2px;
  transform: translate(-6px, 5px) rotateZ(-135deg);
  transform-origin: 2px 2px;
  background: var(--background-white);
}

.checkbox:checked + .dummy-checkbox::after {
  content: "";
  display: block;
  position: absolute;
  top: 50%;
  left: 50%;
  width: 100%;
  height: 4px;
  border-radius: 2px;
  transform: translate(-6px, 5px) rotateZ(-45deg);
  transform-origin: 2px 2px;
  background: var(--background-white);
}

.dummy-checkbox {
  position: relative;
  top: 0;
  left: 0;
  display: block;
  width: 20px;
  height: 20px;
  border: solid 2px transparent;
  background: rgba(0, 0, 0, 0.15);
  border-radius: 50%;
  transition: all 0.15s linear;
}

.task-name {
  font-size: 20px;
  color: var(--font-black);
}
</style>
